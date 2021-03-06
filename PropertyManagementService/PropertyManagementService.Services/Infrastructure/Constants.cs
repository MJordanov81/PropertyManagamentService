﻿namespace PropertyManagementService.Services.Infrastructure
{
    public class Constants
    {
        public const string UserOrBuildingDoNotExistError = "User or building with given ids do not exist.";

        public const string ApartmentDoesNotExistError = "Apartment with the given number already exists.";

        public const string NoAuthorizationError = "No authorization!";

        public const string NoInvoicesError = "All bills have been invoiced";

        public const string NoUtitlitiesError = "There are no utilities to invoice.";

        public const string CannotFindBuildingWithIdError = "Cannot find building with id {0}";

        public const string UtilityAlreadyExists = "Utility with name {0} already exists.";
    }
}
