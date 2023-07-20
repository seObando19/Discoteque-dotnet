/* namespace = le dice a las demas clases donde esta ubicada */
namespace Discoteque.Data.Models;

/*
public = scope de la app, quien puede acceder a la clase
class = tipo de cosa que estoy armando
BaseEntity = name class
<TId> = tipo inferenciado generico (este tipo se va a declarar quien vaya a a usar la clase)
struct = sirve para referenciar data
*/
public class BaseEntity<TId> where TId : struct
{
  public TId Id { get; set; }
}