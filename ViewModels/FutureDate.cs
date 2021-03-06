﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.ViewModels
{
    public sealed class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "d MMM yyyy", CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out DateTime datatime);

            return isValid && datatime > DateTime.Now;

        }
    }
}