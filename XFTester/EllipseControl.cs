using System;
using NControl.Abstractions;
using Xamarin.Forms;

namespace XFTester
{
	public class EllipseControl: NControlView
	{
		public EllipseControl()
		{			
		}

		/// <summary>
		/// The FillColor property.
		/// </summary>
		public static BindableProperty FillColorProperty = 
			BindableProperty.Create<EllipseControl, Xamarin.Forms.Color> (p => p.FillColor, Xamarin.Forms.Color.Black,
				propertyChanged: (bindable, oldValue, newValue) => {
					var ctrl = (EllipseControl)bindable;
					ctrl.FillColor = newValue;
				});

		/// <summary>
		/// Gets or sets the FillColor of the EllipseControl instance.
		/// </summary>
		/// <value>The color of the buton.</value>
		public Xamarin.Forms.Color FillColor {
			get{ return (Xamarin.Forms.Color)GetValue (FillColorProperty); }
			set {
				SetValue (FillColorProperty, value);
				Invalidate ();
			}
		}

		public override void Draw (NGraphics.ICanvas canvas, NGraphics.Rect rect)
		{
			base.Draw (canvas, rect);
			canvas.DrawEllipse (rect, null, new NGraphics.SolidBrush (new NGraphics.Color (FillColor.R, FillColor.G, FillColor.B, FillColor.A)));
		}
	}
}

