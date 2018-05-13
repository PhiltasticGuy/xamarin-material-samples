namespace Xamarin.Material.Samples.Lists
{
    class ListItemDataSource
    {
        static ListItem[] BuiltInItems = {
            new ListItem {
                PrimaryText = "PrimaryTextPrimaryTextPrimaryTextPrimaryText",
                IconText = 'A'
            },
            new ListItem {
                PrimaryText = "PrimaryText PrimaryText PrimaryText PrimaryText",
                IconText = 'B'
            },
            new ListItem {
                PrimaryText = "Primary Text Primary Text Primary Text Primary Text",
                IconText = 'C'
            },
            new ListItem {
                PrimaryText = "Primary Text",
                IconText = 'D'
            },
            new ListItem {
                PrimaryText = "Primary Text",
                IconText = 'E'
            },
            new ListItem {
                PrimaryText = "Primary Text",
                IconText = 'F'
            },
            new ListItem {
                PrimaryText = "Primary Text",
                IconText = 'G'
            },
            new ListItem {
                PrimaryText = "Primary Text",
                IconText = 'H'
            },
            new ListItem {
                PrimaryText = "Primary Text",
                IconText = 'I'
            },
            new ListItem {
                PrimaryText = "Primary Text",
                IconText = 'J'
            },
            new ListItem {
                PrimaryText = "Primary Text",
                IconText = 'K'
            },
            new ListItem {
                PrimaryText = "Primary Text",
                IconText = 'L'
            },
            new ListItem {
                PrimaryText = "Primary Text",
                IconText = 'M'
            },
            new ListItem {
                PrimaryText = "Primary Text",
                IconText = 'N'
            },
            new ListItem {
                PrimaryText = "Primary Text",
                IconText = 'O'
            },
            new ListItem {
                PrimaryText = "Primary Text",
                IconText = 'P'
            },
            new ListItem {
                PrimaryText = "Primary Text",
                IconText = 'Q'
            },
            new ListItem {
                PrimaryText = "Primary Text",
                IconText = 'R'
            },
            new ListItem {
                PrimaryText = "Primary Text",
                IconText = 'S'
            },
            new ListItem {
                PrimaryText = "Primary Text",
                IconText = 'T'
            }
        };

        private ListItem[] _items;

        public int Count => _items.Length;

        public ListItemDataSource() => _items = ListItemDataSource.BuiltInItems;

        public ListItem this[int i] => _items[i];
    }
}