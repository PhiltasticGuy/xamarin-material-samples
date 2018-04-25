using Android.Support.V7.Widget;
using Android.Views;

namespace Xamarin.Material.Samples.Lists.Application.SingleLineItems
{
    public class SingleLineItemViewHolder : RecyclerView.ViewHolder
    {
        public AppCompatTextView PrimaryText { get; private set; }

        public SingleLineItemViewHolder(View itemView)
            : base(itemView)
        {
            PrimaryText = itemView.FindViewById<AppCompatTextView>(Resource.Id.tvPrimary);
        }
    }
}