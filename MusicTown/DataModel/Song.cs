//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicTown.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Song
    {
        public int idSong { get; set; }
        public string nameSong { get; set; }
        public Nullable<int> idKind { get; set; }
        public Nullable<int> idSinger { get; set; }
        public Nullable<int> idPlaylist { get; set; }
        public string url { get; set; }
    
        public virtual Kind Kind { get; set; }
        public virtual Playlist Playlist { get; set; }
        public virtual Singer Singer { get; set; }
    }
}
