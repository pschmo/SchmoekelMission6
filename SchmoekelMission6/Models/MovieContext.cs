﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchmoekelMission6.Models;

public class MovieContext : DbContext
{
    public MovieContext(DbContextOptions<MovieContext> options) : base(options)
    {
    }

    public DbSet<Submission> Movies { get; set; }
}

