﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Otomasyonu2020
{
    class EmanetSilClass:Emanet
    {
        public void delete(string sorgu, Dictionary<string, string> input)
        {
            var cmd = new SqlCommand
            {
                CommandText = sorgu
            };
            foreach (var i in input)
            {
                cmd.Parameters.AddWithValue(i.Key, i.Value);
            }
            cmd.Connection = baglanti;

            cmd.ExecuteNonQuery();
        }
    }
}