using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF NOT EXISTS(SELECT Id from AspNetRoles Where Id = 'e333fcdd-184d-4333-bba4-e6addd0e1274')
                                    BEGIn
                                    	INSERT into AspNetRoles(Id, Name, NormalizedName)
                                    	Values('e333fcdd-184d-4333-bba4-e6addd0e1274', 'admin', 'ADMIN');
                                    END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE AspNetRoles Where Id = 'e333fcdd-184d-4333-bba4-e6addd0e1274'");
        }
    }
}
