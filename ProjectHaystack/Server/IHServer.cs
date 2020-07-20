namespace ProjectHaystack.Server {
  public interface IHServer
  {
    HDict about();
    
    //HGrid call(string op, HGrid req);
    //HGrid call(string op, HGrid req, string mimeType);
    
    //HGrid eval(string expr);
    //HGrid[] evalAll(HGrid req, bool bChecked);
    //HGrid[] evalAll(string[] exprs);
    //HGrid[] evalAll(string[] exprs, bool bChecked);
    HGrid formats();
    HGrid hisRead(HRef id, object range);
    void hisWrite(HRef id, HHisItem[] items);

    HGrid invokeAction(HRef id, string action, HDict args);
    HGrid invokeAction(HRef id, string action, HDict args, string mimetype);

    HGrid ops();

    HGrid pointWrite(HRef id, int level, string who, HVal val, HNum dur);
    HGrid pointWriteArray(HRef id);
  }
}