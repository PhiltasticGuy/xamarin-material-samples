using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;

namespace Xamarin.Material.Samples.Lists.SingleLineItems
{
    public class SingleLineItemAvatarActionViewHolder : RecyclerView.ViewHolder
    {
        public AppCompatTextView PrimaryText { get; private set; }
        public AppCompatTextView AvatarText { get; private set; }
        public AppCompatImageView ActionImage { get; private set; }
        //TODO: PT- What if we want an Avatar Picture instead of just a circle?

        public SingleLineItemAvatarActionViewHolder(View itemView, Action<int> listener)
            : base(itemView)
        {
            PrimaryText = itemView.FindViewById<AppCompatTextView>(Resource.Id.text_primary);
            AvatarText = itemView.FindViewById<AppCompatTextView>(Resource.Id.avatar_text);
            ActionImage = itemView.FindViewById<AppCompatImageView>(Resource.Id.action_image);

            //TODO: PT- What if the parent isn't a RelativeLayout?
            // Hook the event to the action icon's parent to have a reasonable touch/hit target.
            View parent = itemView.FindViewById<RelativeLayout>(Resource.Id.action_container);
            parent.Click += (sender, e) => listener(base.LayoutPosition);
        }
    }
}