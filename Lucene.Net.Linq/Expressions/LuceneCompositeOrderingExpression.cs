﻿using System.Collections.Generic;
using System.Linq.Expressions;
using Remotion.Linq.Clauses.Expressions;
using Remotion.Linq.Parsing;

namespace Lucene.Net.Linq.Expressions
{
    internal class LuceneCompositeOrderingExpression : ExtensionExpression
    {
        public const ExpressionType ExpressionType = (ExpressionType)150003;

        private readonly IEnumerable<LuceneQueryFieldExpression> fields;

        public LuceneCompositeOrderingExpression(IEnumerable<LuceneQueryFieldExpression> fields)
            : base(typeof(object), ExpressionType)
        {
            this.fields = fields;
        }

        public IEnumerable<LuceneQueryFieldExpression> Fields
        {
            get { return fields; }
        }

        protected override Expression VisitChildren(ExpressionTreeVisitor visitor)
        {
            return this;
        }
    }
}