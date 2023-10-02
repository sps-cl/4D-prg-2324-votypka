﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.models;
using LibraryApp.exceptions;


namespace LibraryApp
{
    internal class Library<T> where T : LibraryItem<T>
    {
        List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void ListItems()
        {
            Console.WriteLine("knihovni predmety: ");
            foreach (T item in items)
            {
                item.DisplayInfo();

            }

        }
        public void CheckoutItems(int id)
        {
            T itemToCheckout = items.Find(item => item.Id == id);
            if (itemToCheckout != null)
            {
                if (itemToCheckout.IsAvailable)
                {
                    itemToCheckout.IsAvailable = false;
                    Console.WriteLine($"vypujčit si knihu  {itemToCheckout.Title}");

                }
                else
                {
                    throw new NotAvailableException($"položka s ID $ {itemToCheckout.Id} nebyla nalezena");
                }
            }
            else
            {
                throw new NotFoundException();

            }
            }

        }
    }
