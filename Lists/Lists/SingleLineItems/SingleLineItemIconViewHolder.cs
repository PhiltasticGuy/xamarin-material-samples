using Android.Support.V7.Widget;
using Android.Views;

namespace Xamarin.Material.Samples.Lists.SingleLineItems
{
    public class SingleLineItemIconViewHolder : RecyclerView.ViewHolder
    {
        public AppCompatTextView PrimaryText { get; private set; }
        public AppCompatImageView Icon { get; private set; }

        public SingleLineItemIconViewHolder(View itemView)
            : base(itemView)
        {
            PrimaryText = itemView.FindViewById<AppCompatTextView>(Resource.Id.tvPrimary);
            Icon = itemView.FindViewById<AppCompatImageView>(Resource.Id.icon_main);
        }
    }
}