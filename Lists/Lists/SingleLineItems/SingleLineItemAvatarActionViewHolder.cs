using Android.Support.V7.Widget;
using Android.Views;

namespace Xamarin.Material.Samples.Lists.SingleLineItems
{
    public class SingleLineItemAvatarActionViewHolder : RecyclerView.ViewHolder
    {
        public AppCompatTextView PrimaryText { get; private set; }
        public AppCompatTextView AvatarText { get; private set; }
        //TODO: PT- What if we want an Avatar Picture instead of just a circle?
        //TODO: PT- Secondary action statefulness? (Favorited, Checked, etc.)

        public SingleLineItemAvatarActionViewHolder(View itemView)
            : base(itemView)
        {
            PrimaryText = itemView.FindViewById<AppCompatTextView>(Resource.Id.text_primary);
            AvatarText = itemView.FindViewById<AppCompatTextView>(Resource.Id.avatar_text);
        }
    }
}