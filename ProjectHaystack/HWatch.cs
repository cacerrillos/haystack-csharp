﻿//
// Copyright (c) 2018
// Licensed under the Academic Free License version 3.0
//
// History:
//   1 April 2018 Ian Davies Creation based on Java Toolkit at same time from project-haystack.org downloads
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHaystack
{
    /**
     * HWatch models a subscription to a list of entity records.
     * Use HProj.watchOpen to create a new watch.
     *
     * @see <a href='http://project-haystack.org/doc/Rest#watches'>Project Haystack</a>
     */
    public abstract class HWatch
    {
        /**
         * Unique watch identifier within a project database.
         * The id may not be assigned until after the first call
         * to "sub", in which case return null.
         */
        public abstract string id();

        /**
         * Debug display string used during "HProj.watchOpen"
         */
        public abstract string dis();

        /**
         * Lease period or null if watch has not been opened yet.
         */
        public abstract HNum lease();

        /**
         * Convenience for "sub(ids, true)"
         */
        public HGrid sub(HRef[] ids) { return sub(ids, true); }

        /**
         * Add a list of records to the subscription list and return their
         * current representation.  If checked is true and any one of the
         * ids cannot be resolved then raise UnknownRecException for first id
         * not resolved.  If checked is false, then each id not found has a
         * row where every cell is null.
         * <p>
         * The HGrid that is returned must contain metadata entries
         * for 'watchId' and 'lease'.
         */
        public abstract HGrid sub(HRef[] ids, bool bCheck);

        /**
         * Remove a list of records from watch.  Silently ignore
         * any invalid ids.
         */
        public abstract void unsub(HRef[] ids);

        /**
         * Poll for any changes to the subscribed records.
         */
        public abstract HGrid pollChanges();

        /**
         * Poll all the subscribed records even if there have been no changes.
         */
        public abstract HGrid pollRefresh();

        /**
         * Close the watch and free up any state resources.
         */
        public abstract void close();

        /**
         * Return whether this watch is currently open.
         */
        public abstract bool isOpen();
    }
}
