public ActionResult Template()
        {
            QueryBuilderRule rule = new QueryBuilderRule()
            {
                Condition = "and",
                Rules = new List<QueryBuilderRule>()
                {
                    new QueryBuilderRule { Label="Category", Field="Category", Type="string", Operator="equal", Value = new string[] { "Clothing" } },
                    new QueryBuilderRule { Condition="or", Rules = new List<QueryBuilderRule>() {
                    new QueryBuilderRule { Label="Transaction Type", Field="TransactionType", Type="boolean", Operator="equal", Value = "Income" },
                    new QueryBuilderRule { Label="Payment Mode", Field="PaymentMode", Type="string", Operator="equal", Value = "Cash" }
                    } },
                    new QueryBuilderRule { Label="Amount", Field="Amount", Type="number", Operator="equal", Value = 10 }
                }
            };

            Temp template = new Temp()
            {
                create = "paymentCreate",
                destroy = "paymentDestroy",
                write = "paymentWrite"
            };

            List<object> paymentOperator = new List<object> {
                new { key = "Equal", value = "equal" },
                new { key = "Not Equal", value = "notequal" },
                new { key = "In", value = "in" },
                new { key = "Not In", value = "notin" }
            };

            List<object> transactionOperator = new List<object> {
                new { key = "Equal", value = "equal" },
                new { key = "Not Equal", value = "notequal" }
            };

            List<object> amountOperator = new List<object> {
                new { key = "Equal", value = "equal" },
                new { key = "Greater than", value = "greaterthan" },
                new { key = "Less than", value = "lessthan" },
                new { key = "Less than or equal", value = "lessthanorequal" },
                new { key = "Greater than or equal", value = "greaterthanorequal" },
                new { key = "Not equal", value = "notequal" }
            };

            ViewBag.rule = rule;
            ViewBag.paymentOperator = paymentOperator;
            ViewBag.transactionOperator = transactionOperator;
            ViewBag.amountOperator = amountOperator;
            ViewBag.template = template;
            return View();
        }

        public class Temp
        {
            public string create { get; set; }
            public string destroy { get; set; }
            public string write { get; set; }
        }