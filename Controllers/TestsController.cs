using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WebhookDemo.DataAccess;
using static WebhookDemo.DataAccess.WebhookContext;

namespace WebhookDemo.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestsController : ControllerBase
	{
		[HttpGet]
		public string CheckHealth()
		{
			//using (var db = new WebhookContext())
			//{
			//	var log = new Log { Data = "Test Log" };
			//	db.Add(log);
			//	db.SaveChanges();
			//}
			return "DONE Nhé - 15/06/2022";
		}

		[HttpPost("topic/connections")]
		public string CheckConnection(dynamic obj1)
		{
			using (var db = new WebhookContext())
			{
				var log = new Log { Type = "connections", Data = obj1.ToString() };
				db.Add(log);
				db.SaveChanges();
			}
			return "GO Connection";
		}

		[HttpPost("topic/basicmessages")]
		public string CheckBasicMessage(dynamic obj1)
		{
			using (var db = new WebhookContext())
			{
				var log = new Log { Type = "basicmessages", Data = obj1.ToString() };
				db.Add(log);
				db.SaveChanges();
			}
			return "GO BasicMessage";
		}

		[HttpPost("topic/out_of_band")]
		public string CheckOutOfBand(dynamic obj1)
		{
			using (var db = new WebhookContext())
			{
				var log = new Log { Type = "out_of_band", Data = obj1.ToString() };
				db.Add(log);
				db.SaveChanges();
			}
			return "Go OutOfBand";
		}

		[HttpPost("topic/forward")]
		public string Forward(dynamic obj1)
		{
			using (var db = new WebhookContext())
			{
				var log = new Log { Type = "forward", Data = obj1.ToString() };
				db.Add(log);
				db.SaveChanges();
			}
			return "Go Forward";
		}

		[HttpPost("topic/issue_credential")]
		public string IssueCredential(dynamic obj1)
		{
			using (var db = new WebhookContext())
			{
				var log = new Log { Type = "issue_credential", Data = obj1.ToString() };
				db.Add(log);
				db.SaveChanges();
			}
			return "Go IssueCredential";
		}

		[HttpPost("topic/present_proof")]
		public string PresentProof(dynamic obj1)
		{
			using (var db = new WebhookContext())
			{
				var log = new Log { Type = "present_proof", Data = obj1.ToString() };
				db.Add(log);
				db.SaveChanges();
			}
			return "Go PresentProof";
		}
	}
}
