using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface IGamerValidationService
    {
        bool Validate(Gamer gamer);
    }
}
