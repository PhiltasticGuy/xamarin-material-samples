namespace Xamarin.Material.Samples.Lists.SingleLineItems
{
    class SingleLineItemDataSource
    {
        static SingleLineItem[] BuiltInItems = {
            new SingleLineItem {
                PrimaryText = "SingleLineItemSingleLineItemSingleLineItem"
            },
            new SingleLineItem {
                PrimaryText = "SingleLineItem SingleLineItem SingleLineItem"
            },
            new SingleLineItem {
                PrimaryText = "Single Line Item Single Line Item Single Line Item"
            },
            new SingleLineItem {
                PrimaryText = "Single Line Item"
            },
            new SingleLineItem {
                PrimaryText = "Single Line Item"
            },
            new SingleLineItem {
                PrimaryText = "Single Line Item"
            },
            new SingleLineItem {
                PrimaryText = "Single Line Item"
            },
            new SingleLineItem {
                PrimaryText = "Single Line Item"
            },
            new SingleLineItem {
                PrimaryText = "Single Line Item"
            },
            new SingleLineItem {
                PrimaryText = "Single Line Item"
            },
            new SingleLineItem {
                PrimaryText = "Single Line Item"
            },
            new SingleLineItem {
                PrimaryText = "Single Line Item"
            },
            new SingleLineItem {
                PrimaryText = "Single Line Item"
            },
            new SingleLineItem {
                PrimaryText = "Single Line Item"
            },
            new SingleLineItem {
                PrimaryText = "Single Line Item"
            },
            new SingleLineItem {
                PrimaryText = "Single Line Item"
            },
            new SingleLineItem {
                PrimaryText = "Single Line Item"
            },
            new SingleLineItem {
                PrimaryText = "Single Line Item"
            },
            new SingleLineItem {
                PrimaryText = "Single Line Item"
            },
            new SingleLineItem {
                PrimaryText = "Single Line Item"
            }
        };

        private SingleLineItem[] _items;

        public int Count => _items.Length;

        public SingleLineItemDataSource() => _items = SingleLineItemDataSource.BuiltInItems;

        public SingleLineItem this[int i] => _items[i];
    }
}