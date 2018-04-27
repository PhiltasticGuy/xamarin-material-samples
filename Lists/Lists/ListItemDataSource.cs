namespace Xamarin.Material.Samples.Lists
{
    class ListItemDataSource
    {
        static ListItem[] BuiltInItems = {
            new ListItem {
                PrimaryText = "PrimaryTextPrimaryTextPrimaryTextPrimaryText"
            },
            new ListItem {
                PrimaryText = "PrimaryText PrimaryText PrimaryText PrimaryText"
            },
            new ListItem {
                PrimaryText = "Primary Text Primary Text Primary Text Primary Text"
            },
            new ListItem {
                PrimaryText = "Primary Text"
            },
            new ListItem {
                PrimaryText = "Primary Text"
            },
            new ListItem {
                PrimaryText = "Primary Text"
            },
            new ListItem {
                PrimaryText = "Primary Text"
            },
            new ListItem {
                PrimaryText = "Primary Text"
            },
            new ListItem {
                PrimaryText = "Primary Text"
            },
            new ListItem {
                PrimaryText = "Primary Text"
            },
            new ListItem {
                PrimaryText = "Primary Text"
            },
            new ListItem {
                PrimaryText = "Primary Text"
            },
            new ListItem {
                PrimaryText = "Primary Text"
            },
            new ListItem {
                PrimaryText = "Primary Text"
            },
            new ListItem {
                PrimaryText = "Primary Text"
            },
            new ListItem {
                PrimaryText = "Primary Text"
            },
            new ListItem {
                PrimaryText = "Primary Text"
            },
            new ListItem {
                PrimaryText = "Primary Text"
            },
            new ListItem {
                PrimaryText = "Primary Text"
            },
            new ListItem {
                PrimaryText = "Primary Text"
            }
        };

        private ListItem[] _items;

        public int Count => _items.Length;

        public ListItemDataSource() => _items = ListItemDataSource.BuiltInItems;

        public ListItem this[int i] => _items[i];
    }
}