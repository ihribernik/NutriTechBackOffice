﻿using NutriTechBackOffice.Domain.Entities;
using Google.Cloud.Firestore;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NutriTechBackOffice.Services.Roles.Queries;

namespace NutriTechBackOffice.Services.Roles.Commands
{
    public class InserRoleCommandHandler : IRequestHandler<InsertRoleCommand, Role>
    {
        private CollectionReference rolesRef;
        private WriteResult result;


        public InserRoleCommandHandler(FirestoreDb firestore)
        {
            rolesRef = firestore.Collection("Roles");
        }
        public async Task<Role> Handle(InsertRoleCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Role role = new Role()
                {
                    Nombre = request.Role.Nombre,
                    Descripcion = request.Role.Descripcion,
                };

                result = await this.rolesRef.Document(request.Role.Nombre).SetAsync(role);
                if (result == null)
                {
                    return null;
                }

                return role;
            }
            catch
            {
                throw;
            }
        }
    }
}
