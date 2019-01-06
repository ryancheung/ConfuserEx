﻿using Confuser.Core;
using Confuser.Renamer.Services;
using dnlib.DotNet;

namespace Confuser.Renamer.References {
	public class TypeRefReference : INameReference<TypeDef> {
		readonly TypeDef typeDef;
		readonly TypeRef typeRef;

		public TypeRefReference(TypeRef typeRef, TypeDef typeDef) {
			this.typeRef = typeRef;
			this.typeDef = typeDef;
		}

		public bool UpdateNameReference(IConfuserContext context, INameService service) {
			typeRef.Namespace = typeDef.Namespace;
			typeRef.Name = typeDef.Name;
			return true;
		}

		public bool ShouldCancelRename() => false;
	}
}