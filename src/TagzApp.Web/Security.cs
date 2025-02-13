﻿namespace TagzApp.Web;

/// <summary>
/// A collection of string constants used to define the Roles and Policies used in the application.
/// </summary>
public static class Security {

	public static class Role
	{
		public const string Admin = "Admin";

		public const string Moderator = "Moderator";
	}

	public static class Policy
	{

		public const string AdminRoleOnly = "AdminRoleOnly";
		public const string Moderator = "Moderator";

	}

}