using Android.Support.V7.Widget;
using Android.Views;

namespace Xamarin.Material.Samples.Lists.SingleLineItems
{
    class SingleLineItemAvatarActionAdapter : RecyclerView.Adapter
    { 
        public ListItemDataSource Items { get; private set; }

        public override int ItemCount => Items.Count;

        public SingleLineItemAvatarActionAdapter(ListItemDataSource items) => Items = items;

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView =
                LayoutInflater
                    .From(parent.Context)
                    .Inflate(Resource.Layout.single_line_item_avatar_action, parent, false);

            SingleLineItemAvatarActionViewHolder vh = new SingleLineItemAvatarActionViewHolder(itemView);

            return vh;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            SingleLineItemAvatarActionViewHolder vh = holder as SingleLineItemAvatarActionViewHolder;
            
            vh.PrimaryText.Text = Items[position].PrimaryText + $" #{(position + 1)}";
            vh.AvatarText.Text = Items[position].AvatarText.ToString();
        }
    }
}