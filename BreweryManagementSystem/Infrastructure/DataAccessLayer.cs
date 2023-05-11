using System;
using BreweryManagementSystem.Models;

namespace BreweryManagementSystem.Infrastructure
{
	public class DataAccessLayer : IDataAccessLayer
	{
		BreweryManagementSystemContext? context = null;

        public DataAccessLayer(BreweryManagementSystemContext context)
		{
			this.context = context; 
		}
	}
}

