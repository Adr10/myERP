using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace myERP.Data.Contexts.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cines",
                columns: new[] { "cineId", "CreateAt", "Nombre", "Ubicacion", "UpdateAt", "updatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agora Mall", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.9388777 18.4839233)"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sambil", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.911582 18.482455)"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Megacentro", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.856309 18.506662)"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Acropolis", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.939248 18.469649)"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "CreateAt", "Nombre", "UpdateAt", "updatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Acción", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animación", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comedia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ciencia ficción", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Drama", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "Id", "CreateAt", "EnCartelera", "FechaEstreno", "PosterURL", "Titulo", "UpdateAt", "updatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2012, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/en/8/8a/The_Avengers_%282012_film%29_poster.jpg", "Avengers", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2017, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/en/9/98/Coco_%282017_film%29_poster.jpg", "Coco", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/en/0/00/Spider-Man_No_Way_Home_poster.jpg", "Spider-Man: No way home", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/en/0/00/Spider-Man_No_Way_Home_poster.jpg", "Spider-Man: Far From Home", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), "https://upload.wikimedia.org/wikipedia/en/5/50/The_Matrix_Resurrections.jpg", "The Matrix Resurrections", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                schema: "peliculas",
                table: "TablaActores",
                columns: new[] { "Id", "ColumBiografia", "CreateAt", "FechaNacimiento", "Nombre", "UpdateAt", "updatedBy" },
                values: new object[,]
                {
                    { 1, "Thomas Stanley Holland (Kingston upon Thames, Londres; 1 de junio de 1996), conocido simplemente como Tom Holland, es un actor, actor de voz y bailarín británico.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom Holland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Samuel Leroy Jackson (Washington D. C., 21 de diciembre de 1948), conocido como Samuel L. Jackson, es un actor y productor de cine, televisión y teatro estadounidense. Ha sido candidato al premio Óscar, a los Globos de Oro y al Premio del Sindicato de Actores, así como ganador de un BAFTA al mejor actor de reparto.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1948, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel L. Jackson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Robert John Downey Jr. (Nueva York, 4 de abril de 1965) es un actor, actor de voz, productor y cantante estadounidense. Inició su carrera como actor a temprana edad apareciendo en varios filmes dirigidos por su padre, Robert Downey Sr., y en su infancia estudió actuación en varias academias de Nueva York.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1965, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert Downey Jr.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chris Evans", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1972, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dwayne Johnson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Auli'i Cravalho", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scarlett Johansson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keanu Reeves", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "ActoresPeliculas",
                columns: new[] { "ActorId", "PeliculaId", "CreateAt", "Orden", "Personaje", "UpdateAt", "updatedBy" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Peter Parker", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 1, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Peter Parker", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Samuel L. Jackson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Iron Man", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Capitán América", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Black Widow", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Neo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "CinesOfertas",
                columns: new[] { "Id", "CineId", "CreateAt", "FechaFin", "FechaInicio", "PorcentajeDescuento", "UpdateAt", "updatedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), 10m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), 15m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "GeneroPelicula",
                columns: new[] { "GenerosId", "PeliculasId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 4, 1 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "SalasDeCines",
                columns: new[] { "Id", "CineId", "CreateAt", "Precio", "TipoSalaDeCine", "UpdateAt", "updatedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 220m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 320m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 290m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 330m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 450m, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "PeliculaSalaDeCine",
                columns: new[] { "PeliculasId", "SalaDeCinesId" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "CinesOfertas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CinesOfertas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GeneroPelicula",
                keyColumns: new[] { "GenerosId", "PeliculasId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "GeneroPelicula",
                keyColumns: new[] { "GenerosId", "PeliculasId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "GeneroPelicula",
                keyColumns: new[] { "GenerosId", "PeliculasId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "GeneroPelicula",
                keyColumns: new[] { "GenerosId", "PeliculasId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "GeneroPelicula",
                keyColumns: new[] { "GenerosId", "PeliculasId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "GeneroPelicula",
                keyColumns: new[] { "GenerosId", "PeliculasId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "GeneroPelicula",
                keyColumns: new[] { "GenerosId", "PeliculasId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "GeneroPelicula",
                keyColumns: new[] { "GenerosId", "PeliculasId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "GeneroPelicula",
                keyColumns: new[] { "GenerosId", "PeliculasId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "GeneroPelicula",
                keyColumns: new[] { "GenerosId", "PeliculasId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "GeneroPelicula",
                keyColumns: new[] { "GenerosId", "PeliculasId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "GeneroPelicula",
                keyColumns: new[] { "GenerosId", "PeliculasId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculasId", "SalaDeCinesId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculasId", "SalaDeCinesId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculasId", "SalaDeCinesId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculasId", "SalaDeCinesId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculasId", "SalaDeCinesId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculasId", "SalaDeCinesId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "PeliculaSalaDeCine",
                keyColumns: new[] { "PeliculasId", "SalaDeCinesId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cines",
                keyColumn: "cineId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cines",
                keyColumn: "cineId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cines",
                keyColumn: "cineId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cines",
                keyColumn: "cineId",
                keyValue: 3);
        }
    }
}
