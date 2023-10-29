//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public static void Main(string[] args)
{
    PopulateCatalogs();

    IRecipePrintData recipe = new Recipe(); // Recipe ahora implementa IRecipePrintData
    recipe.FinalProduct = GetProduct("Café con leche");
    recipe.AddStep(GetProduct("Café"), 100, GetEquipment("Cafetera"), 120);
    recipe.AddStep(GetProduct("Leche"), 200, GetEquipment("Hervidor"), 60);
    recipe.AddStep("Dejar enfriar", 60);

    IPrinter printer;
    printer = new ConsolePrinter();
    printer.PrintRecipe(recipe);
    printer = new FilePrinter();
    printer.PrintRecipe(recipe);
}
