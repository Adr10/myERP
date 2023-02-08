using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myERP.Data.Contexts.Migrations
{
    public partial class borrado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "estaBorrado",
                table: "Generos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 1, 3 },
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 1, 4 },
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 2, 4 },
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 3, 1 },
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 4, 1 },
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 7, 1 },
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 8, 5 },
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Cines",
                keyColumn: "cineId",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Cines",
                keyColumn: "cineId",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "Cines",
                keyColumn: "cineId",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Cines",
                keyColumn: "cineId",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "CinesOfertas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3719), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "CinesOfertas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3762), new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "FechaEstreno" },
                values: new object[] { new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3867), new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3762));

            migrationBuilder.UpdateData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 1, 20, 14, 50, 36, 975, DateTimeKind.Utc).AddTicks(3663));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "estaBorrado",
                table: "Generos");

            migrationBuilder.UpdateData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 1, 3 },
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 1, 4 },
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 2, 4 },
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 3, 1 },
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 4, 1 },
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 7, 1 },
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ActoresPeliculas",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 8, 5 },
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cines",
                keyColumn: "cineId",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cines",
                keyColumn: "cineId",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cines",
                keyColumn: "cineId",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Cines",
                keyColumn: "cineId",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CinesOfertas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "CinesOfertas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "FechaFin", "FechaInicio" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Generos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "FechaEstreno" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SalasDeCines",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "peliculas",
                table: "TablaActores",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
