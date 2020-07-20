using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectHaystack.Server {
  public class HServer : HProj, IHServer {
    HDateTime bootTime = HDateTime.now();

    public override HDict about() {
      return new HDictBuilder()
        .add("haystackVersion", "3.0")
        .add("serverTime", HDateTime.now())
        .add("serverBootTime", bootTime)
        .add("tz", HTimeZone.Default.ToString())
        .toDict();
        //.add(onAbout())
    }

    public HGrid formats() {
      throw new NotImplementedException();
    }

    public override HGrid hisRead(HRef id, object range) {
      throw new NotImplementedException();
    }

    public override void hisWrite(HRef id, HHisItem[] items) {
      throw new NotImplementedException();
    }

    public HGrid invokeAction(HRef id, string action, HDict args) {
      throw new NotImplementedException();
    }

    public HGrid invokeAction(HRef id, string action, HDict args, string mimetype) {
      throw new NotImplementedException();
    }

    public HGrid ops() {
      throw new NotImplementedException();
    }

    public HGrid pointWrite(HRef id, int level, string who, HVal val, HNum dur) {
      throw new NotImplementedException();
    }

    public HGrid pointWriteArray(HRef id) {
      throw new NotImplementedException();
    }

    public override HWatch watch(string id, bool bChecked) {
      throw new NotImplementedException();
    }

    public override HWatch[] watches() {
      throw new NotImplementedException();
    }

    public override HWatch watchOpen(string dis, HNum lease) {
      throw new NotImplementedException();
    }

    protected override HGrid onReadAll(string filter, int limit) {
      throw new NotImplementedException();
    }

    protected override HDict onReadById(HRef id) {
      throw new NotImplementedException();
    }

    protected override HGrid onReadByIds(HRef[] ids) {
      throw new NotImplementedException();
    }
  }
}
