//Author: Joshua Ng
//File Name: Buisness_Software.cs
//Project Name: Buisness Software
//Creation Date: October 1, 2019
//Description: This file is a replicated system inventory.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Software
{  
    // Interface for saving and loading a generic object to FileRepository.
    interface IFileRepository<T>
    {
        List<T> load();
        void save(List<T> objs);
    }
}
