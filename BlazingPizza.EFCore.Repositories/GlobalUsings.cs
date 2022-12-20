global using System.Reflection;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Design;
global using BlazingPizza.EFCore.Repositories.Entities;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using BlazingPizzaBusinessObjects.Dtos;
global using BlazingPizzaBusinessObjects.Interfaces;
global using BlazingPizza.EFCore.Repositories.DataContexts;
global using BlazingPizza.EFCore.Repositories.Mappers;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Configuration;


/*
 * add-migration InitialCreate -p BlazingPizza.EFCore.Repositories -s BlazingPizza.EFCore.Repositories -c BlazinfPizzaContext
 * update-database -p BlazingPizza.EFCore.Repositories -s BlazingPizza.EFCore.Repositories 
 */