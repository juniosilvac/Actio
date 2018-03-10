using System;

namespace Actio.Common.Commands
{
  public class IAuthenticatedCommand : ICommand
  {    
    Guid UserId { get; set; }
  }
}