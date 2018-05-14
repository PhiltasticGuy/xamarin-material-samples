using Android.Support.V7.Widget;
using Android.Views;

namespace Xamarin.Material.Samples.Lists.SingleLineItems
{
    class SingleLineItemAvatarAdapter : RecyclerView.Adapter
    { 
        public ListItemDataSource Items { get; private set; }

        public override int ItemCount => Items.Count;

        public SingleLineItemAvatarAdapter(ListItemDataSource items) => Items = items;

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView =
                LayoutInflater
                    .From(parent.Context)
                    .Inflate(Resource.Layout.single_line_item_avatar, parent, false);

            SingleLineItemAvatarViewHolder vh = new SingleLineItemAvatarViewHolder(itemView);

            return vh;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            SingleLineItemAvatarViewHolder vh = holder as SingleLineItemAvatarViewHolder;
            
            vh.PrimaryText.Text = Items[position].PrimaryText + $" #{(position + 1)}";
            vh.AvatarText.Text = Items[position].AvatarText.ToString();
        }
    }
}