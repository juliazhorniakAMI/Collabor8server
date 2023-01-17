using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace app.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spheres",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spheres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Pass = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Purpose = table.Column<string>(type: "text", nullable: false),
                    SphereId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Spheres_SphereId",
                        column: x => x.SphereId,
                        principalTable: "Spheres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SphereSkills",
                columns: table => new
                {
                    SphereId = table.Column<string>(type: "text", nullable: false),
                    SkillId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SphereSkills", x => new { x.SphereId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_SphereSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SphereSkills_Spheres_SphereId",
                        column: x => x.SphereId,
                        principalTable: "Spheres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Collabor8ors",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    SphereId = table.Column<string>(type: "text", nullable: false),
                    BackgroundSummary = table.Column<string>(type: "text", nullable: true),
                    Resume = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collabor8ors", x => new { x.UserId, x.SphereId });
                    table.ForeignKey(
                        name: "FK_Collabor8ors_Spheres_SphereId",
                        column: x => x.SphereId,
                        principalTable: "Spheres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Collabor8ors_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Founders",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ProjectId = table.Column<int>(type: "integer", nullable: false),
                    BackgroundSummary = table.Column<string>(type: "text", nullable: true),
                    Resume = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Founders", x => new { x.UserId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_Founders_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Founders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSkills",
                columns: table => new
                {
                    SkillId = table.Column<string>(type: "text", nullable: false),
                    ProjectId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSkills", x => new { x.SkillId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_ProjectSkills_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSupportInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProjectId = table.Column<int>(type: "integer", nullable: false),
                    Idea = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSupportInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectSupportInfo_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "C8orSkills",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    SphereId = table.Column<string>(type: "text", nullable: false),
                    SkillId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C8orSkills", x => new { x.UserId, x.SphereId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_C8orSkills_Collabor8ors_UserId_SphereId",
                        columns: x => new { x.UserId, x.SphereId },
                        principalTable: "Collabor8ors",
                        principalColumns: new[] { "UserId", "SphereId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_C8orSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "C8orsProjects",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    SphereId = table.Column<string>(type: "text", nullable: false),
                    ProjectId = table.Column<int>(type: "integer", nullable: false),
                    ProposedURL = table.Column<string>(type: "text", nullable: true),
                    AgreementURL = table.Column<string>(type: "text", nullable: true),
                    Direction = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C8orsProjects", x => new { x.UserId, x.SphereId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_C8orsProjects_Collabor8ors_UserId_SphereId",
                        columns: x => new { x.UserId, x.SphereId },
                        principalTable: "Collabor8ors",
                        principalColumns: new[] { "UserId", "SphereId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_C8orsProjects_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_C8orSkills_SkillId",
                table: "C8orSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_C8orsProjects_ProjectId",
                table: "C8orsProjects",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Collabor8ors_SphereId",
                table: "Collabor8ors",
                column: "SphereId");

            migrationBuilder.CreateIndex(
                name: "IX_Founders_ProjectId",
                table: "Founders",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_SphereId",
                table: "Projects",
                column: "SphereId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkills_ProjectId",
                table: "ProjectSkills",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSupportInfo_ProjectId",
                table: "ProjectSupportInfo",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SphereSkills_SkillId",
                table: "SphereSkills",
                column: "SkillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "C8orSkills");

            migrationBuilder.DropTable(
                name: "C8orsProjects");

            migrationBuilder.DropTable(
                name: "Founders");

            migrationBuilder.DropTable(
                name: "ProjectSkills");

            migrationBuilder.DropTable(
                name: "ProjectSupportInfo");

            migrationBuilder.DropTable(
                name: "SphereSkills");

            migrationBuilder.DropTable(
                name: "Collabor8ors");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Spheres");
        }
    }
}
