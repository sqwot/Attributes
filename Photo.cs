﻿using System;

namespace Attributes {
    
    class Photo {
        [Geo(10, 20)]
        public string Name { get; set; }
        public string Path { get; set; }

        [Geo(10, 20)]
        public Photo(string name) {
            this.Name = name;
        }
    }
}
