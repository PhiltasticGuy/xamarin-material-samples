using Android.Support.V7.Widget;
using Android.Views;
using System;

namespace Xamarin.Material.Samples.Lists.SingleLineItems
{
    class SingleLineItemActionAdapter : RecyclerView.Adapter
    { 
        public ListItemDataSource Items { get; private set; }

        // Event raised to allow the UI to do some more specific actions.
        public event EventHandler<int> ItemSecondaryActionClicked;

        public override int ItemCount => Items.Count;

        public SingleLineItemActionAdapter(ListItemDataSource items) => Items = items;

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView =
                LayoutInflater
                    .From(parent.Context)
                    .Inflate(Resource.Layout.single_line_item_action, parent, false);

            SingleLineItemActionViewHolder vh = new SingleLineItemActionViewHolder(itemView, OnSecondaryActionClicked);

            return vh;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            SingleLineItemActionViewHolder vh = holder as SingleLineItemActionViewHolder;
            
            vh.PrimaryText.Text = Items[position].PrimaryText + $" #{(position + 1)}";

            if (Items[position].IsChecked)
                vh.ActionImage.SetImageResource(Resource.Drawable.ic_favorite_black_24dp);
            else
                vh.ActionImage.SetImageResource(Resource.Drawable.ic_favorite_border_black_24dp);
        }

        void OnSecondaryActionClicked(int position)
        {
            Items[position].IsChecked = !Items[position].IsChecked;

            NotifyItemChanged(position);

            ItemSecondaryActionClicked?.Invoke(this, position);
        }
    }
}