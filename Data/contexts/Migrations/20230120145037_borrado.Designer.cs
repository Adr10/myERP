﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using myERP.Data.contexts;

#nullable disable

namespace myERP.Data.Contexts.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230120145037_borrado")]
    partial class borrado
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GeneroPelicula", b =>
                {
                    b.Property<int>("GenerosId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculasId")
                        .HasColumnType("int");

                    b.HasKey("GenerosId", "PeliculasId");

                    b.HasIndex("PeliculasId");

                    b.ToTable("GeneroPelicula");

                    b.HasData(
                        new
                        {
                            GenerosId = 1,
                            PeliculasId = 1
                        },
                        new
                        {
                            GenerosId = 4,
                            PeliculasId = 1
                        },
                        new
                        {
                            GenerosId = 2,
                            PeliculasId = 2
                        },
                        new
                        {
                            GenerosId = 4,
                            PeliculasId = 3
                        },
                        new
                        {
                            GenerosId = 1,
                            PeliculasId = 3
                        },
                        new
                        {
                            GenerosId = 3,
                            PeliculasId = 3
                        },
                        new
                        {
                            GenerosId = 4,
                            PeliculasId = 4
                        },
                        new
                        {
                            GenerosId = 1,
                            PeliculasId = 4
                        },
                        new
                        {
                            GenerosId = 3,
                            PeliculasId = 4
                        },
                        new
                        {
                            GenerosId = 4,
                            PeliculasId = 5
                        },
                        new
                        {
                            GenerosId = 1,
                            PeliculasId = 5
                        },
                        new
                        {
                            GenerosId = 5,
                            PeliculasId = 5
                        });
                });

            modelBuilder.Entity("myERP.Core.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Biografia")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColumBiografia");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("date");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("date");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TablaActores", "peliculas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Biografia = "Thomas Stanley Holland (Kingston upon Thames, Londres; 1 de junio de 1996), conocido simplemente como Tom Holland, es un actor, actor de voz y bailarín británico.",
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3653),
                            FechaNacimiento = new DateTime(1996, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Tom Holland",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Biografia = "Samuel Leroy Jackson (Washington D. C., 21 de diciembre de 1948), conocido como Samuel L. Jackson, es un actor y productor de cine, televisión y teatro estadounidense. Ha sido candidato al premio Óscar, a los Globos de Oro y al Premio del Sindicato de Actores, así como ganador de un BAFTA al mejor actor de reparto.",
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3658),
                            FechaNacimiento = new DateTime(1948, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Samuel L. Jackson",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Biografia = "Robert John Downey Jr. (Nueva York, 4 de abril de 1965) es un actor, actor de voz, productor y cantante estadounidense. Inició su carrera como actor a temprana edad apareciendo en varios filmes dirigidos por su padre, Robert Downey Sr., y en su infancia estudió actuación en varias academias de Nueva York.",
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3659),
                            FechaNacimiento = new DateTime(1965, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Robert Downey Jr.",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3660),
                            FechaNacimiento = new DateTime(1981, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Chris Evans",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3661),
                            FechaNacimiento = new DateTime(1972, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Dwayne Johnson",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3661),
                            FechaNacimiento = new DateTime(2000, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Auli'i Cravalho",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3662),
                            FechaNacimiento = new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Scarlett Johansson",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3663),
                            FechaNacimiento = new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Keanu Reeves",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("myERP.Core.Entities.ActorPelicula", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("date");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.Property<string>("Personaje")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("date");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ActorId", "PeliculaId");

                    b.HasIndex("PeliculaId");

                    b.ToTable("ActoresPeliculas");

                    b.HasData(
                        new
                        {
                            ActorId = 2,
                            PeliculaId = 4,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3900),
                            Orden = 2,
                            Personaje = "Samuel L. Jackson",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ActorId = 1,
                            PeliculaId = 4,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3897),
                            Orden = 1,
                            Personaje = "Peter Parker",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ActorId = 1,
                            PeliculaId = 3,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3899),
                            Orden = 1,
                            Personaje = "Peter Parker",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ActorId = 3,
                            PeliculaId = 1,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3896),
                            Orden = 2,
                            Personaje = "Iron Man",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ActorId = 7,
                            PeliculaId = 1,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3897),
                            Orden = 3,
                            Personaje = "Black Widow",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ActorId = 4,
                            PeliculaId = 1,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3896),
                            Orden = 1,
                            Personaje = "Capitán América",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ActorId = 8,
                            PeliculaId = 5,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3894),
                            Orden = 1,
                            Personaje = "Neo",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("myERP.Core.Entities.Cine", b =>
                {
                    b.Property<int>("cineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cineId"), 1L, 1);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<Point>("Ubicacion")
                        .HasColumnType("geography");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("date");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("cineId");

                    b.ToTable("Cines");

                    b.HasData(
                        new
                        {
                            cineId = 4,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3718),
                            Nombre = "Acropolis",
                            Ubicacion = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.939248 18.469649)"),
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            cineId = 2,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3714),
                            Nombre = "Sambil",
                            Ubicacion = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.911582 18.482455)"),
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            cineId = 3,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3716),
                            Nombre = "Megacentro",
                            Ubicacion = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.856309 18.506662)"),
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            cineId = 1,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3697),
                            Nombre = "Agora Mall",
                            Ubicacion = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.9388777 18.4839233)"),
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("myERP.Core.Entities.CineOferta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CineId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("date");

                    b.Property<decimal>("PorcentajeDescuento")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("date");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CineId")
                        .IsUnique();

                    b.ToTable("CinesOfertas");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            CineId = 4,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3762),
                            FechaFin = new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            FechaInicio = new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            PorcentajeDescuento = 15m,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 1,
                            CineId = 1,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3719),
                            FechaFin = new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            FechaInicio = new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            PorcentajeDescuento = 10m,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("myERP.Core.Entities.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("date");

                    b.Property<bool>("estaBorrado")
                        .HasColumnType("bit");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Generos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3578),
                            Nombre = "Acción",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            estaBorrado = false
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3580),
                            Nombre = "Animación",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            estaBorrado = false
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3580),
                            Nombre = "Comedia",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            estaBorrado = false
                        },
                        new
                        {
                            Id = 4,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3580),
                            Nombre = "Ciencia ficción",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            estaBorrado = false
                        },
                        new
                        {
                            Id = 5,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3581),
                            Nombre = "Drama",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            estaBorrado = false
                        });
                });

            modelBuilder.Entity("myERP.Core.Entities.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("date");

                    b.Property<bool>("EnCartelera")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaEstreno")
                        .HasColumnType("date");

                    b.Property<string>("PosterURL")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Titulo")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("date");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Peliculas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3793),
                            EnCartelera = false,
                            FechaEstreno = new DateTime(2012, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterURL = "https://upload.wikimedia.org/wikipedia/en/8/8a/The_Avengers_%282012_film%29_poster.jpg",
                            Titulo = "Avengers",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3840),
                            EnCartelera = false,
                            FechaEstreno = new DateTime(2017, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterURL = "https://upload.wikimedia.org/wikipedia/en/9/98/Coco_%282017_film%29_poster.jpg",
                            Titulo = "Coco",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3847),
                            EnCartelera = false,
                            FechaEstreno = new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterURL = "https://upload.wikimedia.org/wikipedia/en/0/00/Spider-Man_No_Way_Home_poster.jpg",
                            Titulo = "Spider-Man: No way home",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3857),
                            EnCartelera = false,
                            FechaEstreno = new DateTime(2019, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PosterURL = "https://upload.wikimedia.org/wikipedia/en/0/00/Spider-Man_No_Way_Home_poster.jpg",
                            Titulo = "Spider-Man: Far From Home",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3867),
                            EnCartelera = true,
                            FechaEstreno = new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            PosterURL = "https://upload.wikimedia.org/wikipedia/en/5/50/The_Matrix_Resurrections.jpg",
                            Titulo = "The Matrix Resurrections",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("myERP.Core.Entities.SalaDeCine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CineId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("date");

                    b.Property<decimal>("Precio")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TipoSalaDeCine")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("date");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CineId");

                    b.ToTable("SalasDeCines");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            CineId = 3,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3760),
                            Precio = 250m,
                            TipoSalaDeCine = 1,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CineId = 3,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3760),
                            Precio = 330m,
                            TipoSalaDeCine = 2,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CineId = 3,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3761),
                            Precio = 450m,
                            TipoSalaDeCine = 3,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CineId = 4,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3762),
                            Precio = 250m,
                            TipoSalaDeCine = 1,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 1,
                            CineId = 1,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3757),
                            Precio = 220m,
                            TipoSalaDeCine = 1,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CineId = 1,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3758),
                            Precio = 320m,
                            TipoSalaDeCine = 2,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CineId = 2,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3759),
                            Precio = 200m,
                            TipoSalaDeCine = 1,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CineId = 2,
                            CreateAt = new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3759),
                            Precio = 290m,
                            TipoSalaDeCine = 2,
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("PeliculaSalaDeCine", b =>
                {
                    b.Property<int>("PeliculasId")
                        .HasColumnType("int");

                    b.Property<int>("SalaDeCinesId")
                        .HasColumnType("int");

                    b.HasKey("PeliculasId", "SalaDeCinesId");

                    b.HasIndex("SalaDeCinesId");

                    b.ToTable("PeliculaSalaDeCine");

                    b.HasData(
                        new
                        {
                            PeliculasId = 5,
                            SalaDeCinesId = 3
                        },
                        new
                        {
                            PeliculasId = 5,
                            SalaDeCinesId = 4
                        },
                        new
                        {
                            PeliculasId = 5,
                            SalaDeCinesId = 1
                        },
                        new
                        {
                            PeliculasId = 5,
                            SalaDeCinesId = 2
                        },
                        new
                        {
                            PeliculasId = 5,
                            SalaDeCinesId = 5
                        },
                        new
                        {
                            PeliculasId = 5,
                            SalaDeCinesId = 6
                        },
                        new
                        {
                            PeliculasId = 5,
                            SalaDeCinesId = 7
                        });
                });

            modelBuilder.Entity("GeneroPelicula", b =>
                {
                    b.HasOne("myERP.Core.Entities.Genero", null)
                        .WithMany()
                        .HasForeignKey("GenerosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("myERP.Core.Entities.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("myERP.Core.Entities.ActorPelicula", b =>
                {
                    b.HasOne("myERP.Core.Entities.Actor", "Actor")
                        .WithMany("ActorPelicula")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("myERP.Core.Entities.Pelicula", "Pelicula")
                        .WithMany("ActorPelicula")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("myERP.Core.Entities.CineOferta", b =>
                {
                    b.HasOne("myERP.Core.Entities.Cine", "cine")
                        .WithOne("CineOferta")
                        .HasForeignKey("myERP.Core.Entities.CineOferta", "CineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cine");
                });

            modelBuilder.Entity("myERP.Core.Entities.SalaDeCine", b =>
                {
                    b.HasOne("myERP.Core.Entities.Cine", "cine")
                        .WithMany("SalasDeCine")
                        .HasForeignKey("CineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cine");
                });

            modelBuilder.Entity("PeliculaSalaDeCine", b =>
                {
                    b.HasOne("myERP.Core.Entities.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("myERP.Core.Entities.SalaDeCine", null)
                        .WithMany()
                        .HasForeignKey("SalaDeCinesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("myERP.Core.Entities.Actor", b =>
                {
                    b.Navigation("ActorPelicula");
                });

            modelBuilder.Entity("myERP.Core.Entities.Cine", b =>
                {
                    b.Navigation("CineOferta");

                    b.Navigation("SalasDeCine");
                });

            modelBuilder.Entity("myERP.Core.Entities.Pelicula", b =>
                {
                    b.Navigation("ActorPelicula");
                });
#pragma warning restore 612, 618
        }
    }
}
