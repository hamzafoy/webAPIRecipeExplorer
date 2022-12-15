﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace WebAPIRecipes.Models
{
    public class Database
    {
        public SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebAPIRecipes;Integrated Security=True;Connect Timeout=30;");

        public void RecipeCreate(Recipe recip)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SPROC_RecipesAdd"))
                {
                    string recipeName = recip.Name;
                    string recipeDescription = recip.Description;
                    string recipeCuisines = recip.Cuisines[0];
                    string recipeInstructions = recip.Instructions[0];
                    string recipeIngredients = recip.Ingredients[0];
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", recipeName);
                    cmd.Parameters.AddWithValue("@Description", recip.Description);
                    cmd.Parameters.AddWithValue("@Cuisines", recip.Cuisines[0]);
                    cmd.Parameters.AddWithValue("@Instructions", recip.Instructions[0]);
                    cmd.Parameters.AddWithValue("@Ingredients", recip.Ingredients[0]);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
