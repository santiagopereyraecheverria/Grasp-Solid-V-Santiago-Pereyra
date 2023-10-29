//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{
public class Recipe : IRecipePrintData
{

    public string GetTextToPrint()
    {
        string result = $"Receta de {this.FinalProduct.Description}:\n";
        foreach (BaseStep step in this.steps)
        {
            result = result + step.GetTextToPrint() + "\n";
        }

        result = result + $"Costo de producción: {this.GetProductionCost()}";

        return result;
    }

}
