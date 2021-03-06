﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HuffmanCoding
{
    // приоритетная очередь, за основу взята очередь из книги Рода Стивенсона Алгоритмы

    class PriorityQueue<T>
    {
        // The items and priorities.
        List<T> Values = new List<T>();
        List<int> Priorities = new List<int>();

        // Return the number of items in the queue.
        public int NumItems
        {
            get
            {
                return Values.Count;
            }
        }

        // Add an item to the queue.
        public void Add(T new_value, int new_priority)
        {
            Values.Add(new_value);
            Priorities.Add(new_priority);
        }

        // Remove the item with the largest priority from the queue.
        public void Poll(out T top_value, out int top_priority)
        {
            // Find the hightest priority.
            int best_index = 0;
            int best_priority = Priorities[0];
            for (int i = 1; i < Priorities.Count; i++)
            {
                if (best_priority > Priorities[i])
                {
                    best_priority = Priorities[i];
                    best_index = i;
                }
            }

            // Return the corresponding item.
            top_value = Values[best_index];
            top_priority = best_priority;

            // Remove the item from the lists.
            Values.RemoveAt(best_index);
            Priorities.RemoveAt(best_index);
        }
    }
}
