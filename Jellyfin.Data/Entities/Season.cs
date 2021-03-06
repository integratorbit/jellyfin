//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor
//     https://github.com/msawczyn/EFDesigner
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Jellyfin.Data.Entities
{
   public partial class Season: global::Jellyfin.Data.Entities.LibraryItem
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected Season(): base()
      {
         // NOTE: This class has one-to-one associations with LibraryRoot, LibraryItem and CollectionItem.
         // One-to-one associations are not validated in constructors since this causes a scenario where each one must be constructed before the other.

         SeasonMetadata = new System.Collections.Generic.HashSet<global::Jellyfin.Data.Entities.SeasonMetadata>();
         Episodes = new System.Collections.Generic.HashSet<global::Jellyfin.Data.Entities.Episode>();

         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static Season CreateSeasonUnsafe()
      {
         return new Season();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="urlid">This is whats gets displayed in the Urls and API requests. This could also be a string.</param>
      /// <param name="_series0"></param>
      public Season(Guid urlid, DateTime dateadded, global::Jellyfin.Data.Entities.Series _series0)
      {
         // NOTE: This class has one-to-one associations with LibraryRoot, LibraryItem and CollectionItem.
         // One-to-one associations are not validated in constructors since this causes a scenario where each one must be constructed before the other.

         this.UrlId = urlid;

         if (_series0 == null) throw new ArgumentNullException(nameof(_series0));
         _series0.Seasons.Add(this);

         this.SeasonMetadata = new System.Collections.Generic.HashSet<global::Jellyfin.Data.Entities.SeasonMetadata>();
         this.Episodes = new System.Collections.Generic.HashSet<global::Jellyfin.Data.Entities.Episode>();

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="urlid">This is whats gets displayed in the Urls and API requests. This could also be a string.</param>
      /// <param name="_series0"></param>
      public static Season Create(Guid urlid, DateTime dateadded, global::Jellyfin.Data.Entities.Series _series0)
      {
         return new Season(urlid, dateadded, _series0);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Backing field for SeasonNumber
      /// </summary>
      protected int? _SeasonNumber;
      /// <summary>
      /// When provided in a partial class, allows value of SeasonNumber to be changed before setting.
      /// </summary>
      partial void SetSeasonNumber(int? oldValue, ref int? newValue);
      /// <summary>
      /// When provided in a partial class, allows value of SeasonNumber to be changed before returning.
      /// </summary>
      partial void GetSeasonNumber(ref int? result);

      public int? SeasonNumber
      {
         get
         {
            int? value = _SeasonNumber;
            GetSeasonNumber(ref value);
            return (_SeasonNumber = value);
         }
         set
         {
            int? oldValue = _SeasonNumber;
            SetSeasonNumber(oldValue, ref value);
            if (oldValue != value)
            {
               _SeasonNumber = value;
            }
         }
      }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      public virtual ICollection<global::Jellyfin.Data.Entities.SeasonMetadata> SeasonMetadata { get; protected set; }

      public virtual ICollection<global::Jellyfin.Data.Entities.Episode> Episodes { get; protected set; }

   }
}

