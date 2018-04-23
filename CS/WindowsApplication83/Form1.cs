using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils.Drawing;

namespace WindowsApplication83 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }
    }

    public class MyRangeTrackBarControl: RangeTrackBarControl {

        public MyRangeTrackBarControl() {
            Properties.Appearance.ForeColor = Color.Black;
        }

        protected RangeTrackBarViewInfo RangeViewInfo { get { return ViewInfo as RangeTrackBarViewInfo; } }

        protected int ThumbTextIndent { get { return 7; } }

        protected Point MinTextPos {
            get { return new Point(RangeViewInfo.MinThumbBounds.Left, RangeViewInfo.MinThumbBounds.Bottom + ThumbTextIndent); }
        }

        protected Point MaxTextPos {
            get { return new Point(RangeViewInfo.MaxThumbBounds.Left - 5, RangeViewInfo.MaxThumbBounds.Bottom + ThumbTextIndent); }
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            GraphicsCache cache = new GraphicsCache(e.Graphics);
            e.Graphics.DrawString(Value.Minimum.ToString(), ViewInfo.PaintAppearance.Font, ViewInfo.PaintAppearance.GetForeBrush(cache), MinTextPos);
            e.Graphics.DrawString(Value.Maximum.ToString(), ViewInfo.PaintAppearance.Font, ViewInfo.PaintAppearance.GetForeBrush(cache), MaxTextPos);
        }
    }
}