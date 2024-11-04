using System;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Animation;
using Avalonia.Animation.Easings;
using Avalonia.Controls;
using Avalonia.Controls.Metadata;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Media;
using Avalonia.Styling;

namespace IconPacks.Avalonia
{
    /// <summary>
    /// Class PackIconControlBase which is the base class for any PackIcon control.
    /// </summary>
    [PseudoClasses(IconDataFlippedVerticallyPseudoClass)]
    [PseudoClasses(IconFilledPseudoClass)]
    [PseudoClasses(IconOutlinedPseudoClass)]
    public abstract class PackIconControlBase : PackIconBase
    {
        /// <summary>
        /// A string representing the pseudo-class when the icon data is flipped vertically
        /// </summary>
        /// <returns>":icon-data-flipped-vertically"</returns>
        public const string IconDataFlippedVerticallyPseudoClass = ":icon-data-flipped-vertically";

        /// <summary>
        /// A string representing the pseudo-class when the icon data is drawn filled
        /// </summary>
        /// <returns>":icon-filled"</returns>
        public const string IconFilledPseudoClass = ":icon-filled";

        /// <summary>
        /// A string representing the pseudo-class when the icon data is drawn outlined
        /// </summary>
        /// <returns>":icon-outlined"</returns>
        public const string IconOutlinedPseudoClass = ":icon-outlined";

        protected PackIconControlBase()
        {
            AffectsRender<PackIconControlBase>(SpinProperty, SpinDurationProperty, OpacityProperty, SpinEasingFunctionProperty, FlipProperty, RotationAngleProperty);
        }

        private bool CanSpin()
        {
            return this.Spin
                   && this.IsVisible
                   && this.SpinDuration > 0
                   && this.Opacity > 0
                   && this.SpinEasingFunction != null;
        }

        private Grid innerGrid;
        private ScaleTransform scaleTransform;
        private RotateTransform rotateTransform;

        /// <inheritdoc />
        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            base.OnApplyTemplate(e);

            this.innerGrid = e.NameScope.Find<Grid>("PART_InnerGrid");

            if (this.innerGrid != null)
            {
                var transformGroup = new TransformGroup();
                this.scaleTransform = new ScaleTransform();
                this.rotateTransform = new RotateTransform();
                transformGroup.Children.Add(scaleTransform);
                transformGroup.Children.Add(rotateTransform);
                this.innerGrid.RenderTransform = transformGroup;
            }

            this.UpdateScaleTransformation(this.Flip);
            this.UpdateRotateTransformation(this.RotationAngle);
            this.UpdateData();

            var spin = CanSpin();
            if (spin)
            {
                this.StopSpinAnimation();
                this.BeginSpinAnimation();
            }
        }

        protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
        {
            base.OnPropertyChanged(change);

            if (change.Property == FlipProperty)
            {
                if (change.NewValue != null && change.NewValue != change.OldValue)
                {
                    this.UpdateScaleTransformation(change.GetNewValue<PackIconFlipOrientation>());
                }
            }
            else if (change.Property == RotationAngleProperty)
            {
                if (change.NewValue != null && change.NewValue != change.OldValue)
                {
                    this.UpdateRotateTransformation(change.GetNewValue<double>());
                }
            }

            // Update Spin-Animation as needed 
            if (change.Property == SpinProperty
                || change.Property == IsVisibleProperty
                || change.Property == SpinDurationProperty
                || change.Property == OpacityProperty
                || change.Property == SpinEasingFunctionProperty)
            {
                this.StopSpinAnimation();

                if (this.CanSpin())
                {
                    this.BeginSpinAnimation();
                }
            }
        }

        private void UpdateScaleTransformation(PackIconFlipOrientation flipOrientation)
        {
            if (this.scaleTransform != null)
            {
                var scaleX = flipOrientation is PackIconFlipOrientation.Horizontal or PackIconFlipOrientation.Both
                    ? -1
                    : 1;
                var scaleY = flipOrientation is PackIconFlipOrientation.Vertical or PackIconFlipOrientation.Both
                    ? -1
                    : 1;
                this.scaleTransform.ScaleX = scaleX;
                this.scaleTransform.ScaleY = scaleY;
            }
        }

        private void UpdateRotateTransformation(double angle)
        {
            if (this.rotateTransform != null)
            {
                this.rotateTransform.Angle = angle;
            }
        }

        /// <summary>
        /// Identifies the Flip dependency property.
        /// </summary>
        public static readonly StyledProperty<PackIconFlipOrientation> FlipProperty
            = AvaloniaProperty.Register<PackIconControlBase, PackIconFlipOrientation>(nameof(Flip));

        /// <summary>
        /// Gets or sets the flip orientation.
        /// </summary>
        public PackIconFlipOrientation Flip
        {
            get { return this.GetValue(FlipProperty); }
            set { this.SetValue(FlipProperty, value); }
        }

        /// <summary>
        /// Identifies the RotationAngle dependency property.
        /// </summary>
        public static readonly StyledProperty<double> RotationAngleProperty
            = AvaloniaProperty.Register<PackIconControlBase, double>(
                nameof(RotationAngle),
                0d,
                false,
                BindingMode.OneWay,
                null,
                (packIcon, value) =>
                {
                    if (value < 0)
                    {
                        return 0d;
                    }

                    return value > 360 ? 360d : value;
                });

        /// <summary>
        /// Gets or sets the rotation (angle).
        /// </summary>
        /// <value>The rotation.</value>
        public double RotationAngle
        {
            get { return this.GetValue(RotationAngleProperty); }
            set { this.SetValue(RotationAngleProperty, value); }
        }

        /// <summary>
        /// Identifies the Spin dependency property.
        /// </summary>
        public static readonly StyledProperty<bool> SpinProperty
            = AvaloniaProperty.Register<PackIconControlBase, bool>(nameof(Spin));

        /// <summary>
        /// Gets or sets a value indicating whether the inner icon is spinning.
        /// </summary>
        /// <value><c>true</c> if spin; otherwise, <c>false</c>.</value>
        public bool Spin
        {
            get { return this.GetValue(SpinProperty); }
            set { this.SetValue(SpinProperty, value); }
        }

        private Animation spinAnimation = null;
        private Task spinAnimationTask = null;

        private void BeginSpinAnimation()
        {
            if (this.innerGrid is null)
            {
                return;
            }

            var animation = spinAnimation ?? new Animation
            {
                Children =
                {
                    new KeyFrame()
                    {
                        Cue = new Cue(0),
                        Setters = { new Setter(RotateTransform.AngleProperty, 0d) }
                    },
                    new KeyFrame()
                    {
                        Cue = new Cue(1),
                        Setters = { new Setter(RotateTransform.AngleProperty, 360d) }
                    }
                }
            };

            animation.Duration = TimeSpan.FromSeconds(this.SpinDuration);
            animation.Easing = this.SpinEasingFunction;
            animation.IterationCount = IterationCount.Infinite;
            this.spinAnimation = animation;
            this.spinAnimationTask = animation.RunAsync(this.innerGrid);
        }

        private void StopSpinAnimation()
        {
            if (this.spinAnimation != null)
            {
                this.spinAnimation.IterationCount = new IterationCount(0);
                this.spinAnimationTask?.Dispose();
                this.spinAnimationTask = null;
            }
        }

        /// <summary>
        /// Identifies the SpinDuration dependency property.
        /// </summary>
        public static readonly StyledProperty<double> SpinDurationProperty
            = AvaloniaProperty.Register<PackIconControlBase, double>(
                nameof(SpinDuration),
                1d,
                false,
                BindingMode.OneWay,
                null,
                (iconPack, value) => value < 0 ? 0d : value);

        /// <summary>
        /// Gets or sets the duration of the spinning animation (in seconds). This will also restart the spin animation.
        /// </summary>
        /// <value>The duration of the spin in seconds.</value>
        public double SpinDuration
        {
            get { return this.GetValue(SpinDurationProperty); }
            set { this.SetValue(SpinDurationProperty, value); }
        }

        /// <summary>
        /// Identifies the SpinEasingFunction dependency property.
        /// </summary>
        public static readonly StyledProperty<Easing> SpinEasingFunctionProperty
            = AvaloniaProperty.Register<PackIconControlBase, Easing>(
                nameof(SpinEasingFunction),
                new LinearEasing());

        /// <summary>
        /// Gets or sets the EasingFunction of the spinning animation. This will also restart the spin animation.
        /// </summary>
        /// <value>The spin easing function.</value>
        public Easing SpinEasingFunction
        {
            get { return this.GetValue(SpinEasingFunctionProperty); }
            set { this.SetValue(SpinEasingFunctionProperty, value); }
        }

        public static readonly StyledProperty<bool> SpinAutoReverseProperty
            = AvaloniaProperty.Register<PackIconControlBase, bool>(nameof(SpinAutoReverse));

        /// <summary>
        /// Gets or sets the AutoReverse of the spinning animation. This will also restart the spin animation.
        /// </summary>
        /// <value><c>true</c> if [spin automatic reverse]; otherwise, <c>false</c>.</value>
        public bool SpinAutoReverse
        {
            get { return this.GetValue(SpinAutoReverseProperty); }
            set { this.SetValue(SpinAutoReverseProperty, value); }
        }

        protected void UpdateIconPseudoClasses(bool filled, bool outlined, bool flipped)
        {
            PseudoClasses.Set(IconFilledPseudoClass, filled);
            PseudoClasses.Set(IconOutlinedPseudoClass, outlined);
            PseudoClasses.Set(IconDataFlippedVerticallyPseudoClass, flipped);
        }
    }
}