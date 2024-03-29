﻿using Microsoft.EntityFrameworkCore;
using RoomApi.Models;

namespace RoomApi.Data
{ 
    public class RoomContext : DbContext
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public RoomContext(DbContextOptions<RoomContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

    }

    public DbSet<Room> Rooms { get; set; }
}

}
