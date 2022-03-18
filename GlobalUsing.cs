global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Migrations;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.Rendering;
global using Microsoft.AspNetCore.Identity;

global using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
global using Microsoft.AspNetCore.Authorization;


global using Newtonsoft.Json;


global using System.ComponentModel.DataAnnotations;

global using TomasosPizzeria.Models;
global using TomasosPizzeria.ModelsIdentity;
global using TomasosPizzeria.Repositories;
global using TomasosPizzeria.ViewModels;

//global using TomasosPizzeria.Services;
//global using TomasosPizzeria.Services.Models;
//global using TomasosPizzeria.Services.Interfaces;


// GlobalUsings gör global usings åtkomliga genom hela projektet
// _ViewImports motsvarighet (fast för .cs-filer)

// För att använda GlobalUsings lägger man till en class i projektet med namn 
// "GlobalUsings.cs" och skriver vilka usings man vill använda - precis som ovan