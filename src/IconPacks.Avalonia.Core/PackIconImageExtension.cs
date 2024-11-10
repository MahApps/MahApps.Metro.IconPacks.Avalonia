using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace IconPacks.Avalonia.Core
{
    public abstract class BasePackIconImageExtension : MarkupExtension
    {
        /// <summary>
        /// Gets or sets the brush to draw the icon.
        /// </summary>
        public IBrush Brush { get; set; } = Brushes.Black;

        /// <summary>
        /// Gets or sets the flip orientation for the icon.
        /// </summary>
        public PackIconFlipOrientation Flip { get; set; } = PackIconFlipOrientation.Normal;

        /// <summary>
        /// Gets or sets the rotation (angle) for the icon.
        /// </summary>
        public double RotationAngle { get; set; } = 0d;

        /// <summary>
        /// Gets the path data for the given kind.
        /// </summary>
        protected abstract string GetPathData(object iconKind);

        /// <summary>
        /// Gets the ScaleTransform for the given kind.
        /// </summary>
        /// <param name="iconKind">The icon kind to draw.</param>
        protected virtual ScaleTransform GetScaleTransform(object iconKind)
        {
            return new ScaleTransform(1, 1);
        }

        /// <summary>
        /// Gets the <see cref="TransformGroup" /> for the <see cref="DrawingGroup" />.
        /// </summary>
        /// <param name="iconKind">The icon kind to draw.</param>
        protected Transform GetTransformGroup(object iconKind)
        {
            var transformGroup = new TransformGroup();
            transformGroup.Children.Add(this.GetScaleTransform(iconKind)); // scale
            transformGroup.Children.Add(new ScaleTransform(
                this.Flip is PackIconFlipOrientation.Horizontal or PackIconFlipOrientation.Both ? -1 : 1,
                this.Flip is PackIconFlipOrientation.Vertical or PackIconFlipOrientation.Both ? -1 : 1
            )); // flip
            transformGroup.Children.Add(new RotateTransform(this.RotationAngle)); // rotate

            return transformGroup;
        }

        /// <summary>
        /// Gets the <see cref="DrawingGroup" /> object that will be used for the <see cref="DrawingImage" />.
        /// </summary>
        protected virtual DrawingGroup GetDrawingGroup(object iconKind, IBrush foregroundBrush, string path)
        {
            var geometryDrawing = new GeometryDrawing
            {
                Geometry = StreamGeometry.Parse(path),
                Brush = foregroundBrush
            };

            var drawingGroup = new DrawingGroup
            {
                Children = { geometryDrawing },
                Transform = this.GetTransformGroup(iconKind)
            };

            return drawingGroup;
        }

        /// <summary>
        /// Gets the ImageSource for the given kind.
        /// </summary>
        protected IImage CreateImageSource(object iconKind, IBrush foregroundBrush)
        {
            var path = this.GetPathData(iconKind);

            if (string.IsNullOrEmpty(path))
            {
                return null;
            }

            var drawingImage = new DrawingImage(GetDrawingGroup(iconKind, foregroundBrush, path));
            return drawingImage;
        }
    }
}