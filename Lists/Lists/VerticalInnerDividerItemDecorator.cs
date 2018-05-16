using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Support.V7.Widget;
using Android.Views;

namespace Xamarin.Material.Samples.Lists
{
    //https://stackoverflow.com/questions/46215810/recyclerview-remove-divider-decorator-after-the-last-item
    public class VerticalInnerDividerItemDecorator : RecyclerView.ItemDecoration
    {
        private Drawable _divider;

        public VerticalInnerDividerItemDecorator(Drawable divider) => _divider = divider;

        public override void OnDraw(Canvas canvas, RecyclerView parent, RecyclerView.State state)
        {
            if ((parent.GetLayoutManager() as LinearLayoutManager)?.Orientation  == LinearLayoutManager.Horizontal)
                throw new System.InvalidOperationException($"The {nameof(LinearLayoutManager)} orientation must be set to Vertical in order to implement the {nameof(VerticalInnerDividerItemDecorator)}");

            int dividerLeft = parent.PaddingLeft;
            int dividerRight = parent.Width - parent.PaddingRight;

            int childCount = parent.ChildCount;
            for (int i = 0; i <= childCount - 2; i++)
            {
                View child = parent.GetChildAt(i);

                RecyclerView.LayoutParams lp = (RecyclerView.LayoutParams)child.LayoutParameters;

                int dividerTop = child.Bottom + lp.BottomMargin;
                int dividerBottom = dividerTop + _divider.IntrinsicHeight;

                _divider.SetBounds(dividerLeft, dividerTop, dividerRight, dividerBottom);
                _divider.Draw(canvas);
            }
        }
}
}