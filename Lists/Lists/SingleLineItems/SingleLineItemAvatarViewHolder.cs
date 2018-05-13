using Android.Support.V7.Widget;
using Android.Views;

namespace Xamarin.Material.Samples.Lists.SingleLineItems
{
    public class SingleLineItemAvatarViewHolder : RecyclerView.ViewHolder
    {
        public AppCompatTextView PrimaryText { get; private set; }
        public AppCompatTextView IconText { get; private set; }

        public SingleLineItemAvatarViewHolder(View itemView)
            : base(itemView)
        {
            PrimaryText = itemView.FindViewById<AppCompatTextView>(Resource.Id.tvPrimary);
            IconText = itemView.FindViewById<AppCompatTextView>(Resource.Id.icon_text);
        }
    }
}