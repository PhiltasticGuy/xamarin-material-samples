using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;

namespace Xamarin.Material.Samples.Lists.SingleLineItems
{
    public class SingleLineItemActionViewHolder : RecyclerView.ViewHolder
    {
        public AppCompatTextView PrimaryText { get; private set; }
        public AppCompatImageView ActionImage { get; private set; }

        public SingleLineItemActionViewHolder(View itemView, Action<int> listener)
            : base(itemView)
        {
            PrimaryText = itemView.FindViewById<AppCompatTextView>(Resource.Id.text_primary);
            ActionImage = itemView.FindViewById<AppCompatImageView>(Resource.Id.action_image);

            //TODO: PT- What if the parent isn't a RelativeLayout?
            // Hook the event to the action icon's parent to have a reasonable touch/hit target.
            View parent = itemView.FindViewById<RelativeLayout>(Resource.Id.action_container);
            parent.Click += (sender, e) => listener(base.LayoutPosition);
        }
    }
}