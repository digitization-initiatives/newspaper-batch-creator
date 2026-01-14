using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

public static class PropertyGridSplitter
{
    public static void SetSplitter(PropertyGrid pg, int xPixelsFromLeft)
    {
        if (pg == null) throw new ArgumentNullException(nameof(pg));

        // Must run after the control has a handle and has been laid out.
        if (!pg.IsHandleCreated)
        {
            pg.HandleCreated += (_, __) => SetSplitter(pg, xPixelsFromLeft);
            return;
        }

        pg.BeginInvoke((Action)(() =>
        {
            var gridView = pg.Controls.Cast<Control>()
                .FirstOrDefault(c => c.GetType().Name == "PropertyGridView");
            if (gridView == null) return;

            var mi = gridView.GetType().GetMethod(
                "MoveSplitterTo",
                BindingFlags.Instance | BindingFlags.NonPublic);

            mi?.Invoke(gridView, new object[] { xPixelsFromLeft });
        }));
    }

    public static void SetSplitterByRatio(PropertyGrid pg, double leftColumnRatio)
    {
        // leftColumnRatio: 0.0..1.0, e.g. 0.30 = 30% left column
        int x = (int)Math.Round(pg.ClientSize.Width * leftColumnRatio);
        SetSplitter(pg, x);
    }
}
