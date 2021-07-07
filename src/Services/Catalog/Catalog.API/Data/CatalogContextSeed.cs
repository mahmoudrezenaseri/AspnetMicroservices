﻿using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                   Name="Nokia 3.4 Dual SIM 64GB And 3GB RAM Mobile Phone",
                    Price=1649000,
                    Category="SmartPhone",
                    ImageFile="product-1.png",
                    Description="نوکیا در سال ۲۰۲۰ دوباره دست به تولید نمونه‌ای دیگر از گوشی‌های خود زده است و یک گوشی میان رده با مدل 3.4 را روانه بازار کرده است. این گوشی می‌تواند در کارهای ساده و نیمه‌سنگین برای شما تمام توانش را به کار گیرد و می‌تواند حتی در بازی‌ها هم در حت متوسط MAP و گرافیک هم شما را یاری کند. این گوشی دارای دوربینی با ۱۳ مگاپیکسل قدرت است و می‌توان تصاویر خوبی را با آن ثبت کرد. دوربین سلفی آن قدرت ۸ مگاپیکسل دارد. در قاب پشتی گوشی موبایل نوکیا مدل 3.4 دو سیم کارت ظرفیت 64 گیگابایت و رم 3 گیگابایت جایی برای اثر انگشت قرار داده اند تا امنیت گوشی را برای کاربر بالاتر ببرند. فناوری صفحه‌نمایش این گوشی نوکیا از IPS بهره می‌برد و تا 400 نیت روشنایی دارد.",
                },
                new Product()
                {
                    Name="Nokia C3 TA-1292DS Dual SIM16GB And 2GB RAM Mobile Phone",
                    Price=2010000,
                    Category="SmartPhone",
                    ImageFile="product-2.png",
                    Description="گوشی موبایل «C3» از سری محصولات جدید و خوش‌ساختی است که از سوی شرکت مطرح «نوکیا» (Nokia) در تاریخ ۴ آگوست ۲۰۲۰ معرفی و روانه بازار شده است. صفحه‌نمایش این گوشی موبایل در اندازه 5.99 اینچ است و از فناوری IPS بهره می برد. این صفحه‌نمایش قسمت زیادی از قاب جلوی محصول را پوشانده است اما هنوز هم در قسمت بالا و پایین حاشیه‌هایی وجود دارند.شرکت نوکیا برای این گوشی قابی از جنس پلاستیک در نظر گرفته است. نوکیا در این محصول خود از یک دوربین 8 مگاپیکسلی استفاده کرده است. دوربین سلفی این محصول هم به سنسوری 5مگاپیکسلی مجهز شده است. قابلیت اتصال به شبکه­‌های 4G، بلوتوث نسخه­‌ی 4.2، نسخه­‌ی 9 از اندروید و باتری 3040 میلی آمپرساعتی از دیگر ویژگی­‌های این گوشی جدید هستند. این محصول به عنوان یک گوشی اقتصادی و مقرون‌به‌صرفه به آن دسته از کاربران توصیه می‌شود که گوشی مدرن اما اقتصادی می‌خواهند.",
                },
                new Product()
                {
                    Name="Nokia C2 TA-1204 DS Dual SIM16GB Mobile Phone",
                    Price=2680000,
                    Category="SmartPhone",
                    ImageFile="product-3.png",
                    Description="گوشی موبایل «C2» از سری محصولات جدید و خوش‌ساختی است که از سوی شرکت مطرح «نوکیا» (Nokia) روانه بازار شده است. صفحه‌نمایش این گوشی موبایل در اندازه 5.7 اینچ است و از فناوری IPS بهره می برد. این صفحه‌نمایش قسمت زیادی از قاب جلوی محصول را پوشانده است اما هنوز هم در قسمت بالا و پایین حاشیه‌هایی وجود دارند. نوکیا در این محصول خود از یک دوربین 5 مگاپیکسلی استفاده کرده است. دوربین سلفی این محصول هم به سنسوری 5مگاپیکسلی مجهز شده است. قابلیت اتصال به شبکه­‌های 4G، بلوتوث نسخه­‌ی 4.2، نسخه­‌ی 9 از اندروید و باتری 2800 میلی آمپرساعتی از دیگر ویژگی­‌های این گوشی جدید هستند. این محصول به عنوان یک گوشی اقتصادی و مقرون‌به‌صرفه به آن دسته از کاربران توصیه می‌شود که گوشی مدرن اما اقتصادی می‌خواهند."
                }
            };
        }
    }
}