﻿using System.Windows;
using System.Windows.Controls;

namespace Imagin.Controls.Extended
{
    public class PropertyItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ShortTemplate
        {
            get; set;
        }

        public DataTemplate ByteTemplate
        {
            get; set;
        }

        public DataTemplate DecimalTemplate
        {
            get; set;
        }

        public DataTemplate LongTemplate
        {
            get; set;
        }

        public DataTemplate DateTimeTemplate
        {
            get; set;
        }

        public DataTemplate LinearGradientBrushTemplate
        {
            get; set;
        }

        public DataTemplate SolidColorBrushTemplate
        {
            get; set;
        }

        public DataTemplate MultiLineTemplate
        {
            get; set;
        }

        public DataTemplate FileSystemObjectTemplate
        {
            get; set;
        }

        public DataTemplate PasswordTemplate
        {
            get; set;
        }

        public DataTemplate StringTemplate
        {
            get; set;
        }

        public DataTemplate IntTemplate
        {
            get; set;
        }

        public DataTemplate DoubleTemplate
        {
            get; set;
        }

        public DataTemplate EnumTemplate
        {
            get; set;
        }

        public DataTemplate BoolTemplate
        {
            get; set;
        }

        public DataTemplate GuidTemplate
        {
            get; set;
        }

        public override DataTemplate SelectTemplate(object _Item, DependencyObject Container)
        {
            PropertyItem Item = _Item as PropertyItem;
            if (Item == null) return base.SelectTemplate(_Item, Container);
            switch (Item.Type)
            {
                case PropertyType.LinearGradientBrush:
                    return LinearGradientBrushTemplate;
                case PropertyType.SolidColorBrush:
                    return SolidColorBrushTemplate;
                case PropertyType.String:
                    return StringTemplate;
                case PropertyType.Int:
                    return IntTemplate;
                case PropertyType.Double:
                    return DoubleTemplate;
                case PropertyType.Enum:
                    return EnumTemplate;
                case PropertyType.Bool:
                    return BoolTemplate;
                case PropertyType.Guid:
                    return GuidTemplate;
                case PropertyType.Password:
                    return PasswordTemplate;
                case PropertyType.FileSystemObject:
                    return FileSystemObjectTemplate;
                case PropertyType.DateTime:
                    return DateTimeTemplate;
                case PropertyType.Long:
                    return LongTemplate;
                case PropertyType.MultiLine:
                    return MultiLineTemplate;
                default:
                    return base.SelectTemplate(_Item, Container);
            }
        }
    }
}
