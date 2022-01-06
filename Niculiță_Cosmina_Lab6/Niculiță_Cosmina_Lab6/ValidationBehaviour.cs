using System;
using System.Collections.Generic;
using System.Text;
using Niculiță_Cosmina_Lab6.Models;
using Niculiță_Cosmina_Lab6.Data;
using Xamarin.Forms;

namespace Niculiță_Cosmina_Lab6
{
    class ValidationBehaviour : Behavior<Editor>
    {
        protected override void OnAttachedTo(Editor entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }
        protected override void OnDetachingFrom(Editor entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }
        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            ((Editor)sender).BackgroundColor =
            string.IsNullOrEmpty(args.NewTextValue) ? Color.Red : Color.Default;
        }
    }
    }
