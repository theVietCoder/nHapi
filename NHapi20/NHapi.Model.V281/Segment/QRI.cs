using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V281.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V281.Segment{

///<summary>
/// Represents an HL7 QRI message segment. 
/// This segment has the following fields:<ol>
///<li>QRI-1: Candidate Confidence (NM)</li>
///<li>QRI-2: Match Reason Code (CWE)</li>
///<li>QRI-3: Algorithm Descriptor (CWE)</li>
///</ol>
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class QRI : AbstractSegment  {

  /**
   * Creates a QRI (Query Response Instance) segment object that belongs to the given 
   * message.  
   */
	public QRI(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(NM), false, 1, 0, new System.Object[]{message}, "Candidate Confidence");
       this.add(typeof(CWE), false, 0, 2, new System.Object[]{message}, "Match Reason Code");
       this.add(typeof(CWE), false, 1, 0, new System.Object[]{message}, "Algorithm Descriptor");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Candidate Confidence(QRI-1).
	///</summary>
	public NM CandidateConfidence
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(1, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns a single repetition of Match Reason Code(QRI-2).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CWE GetMatchReasonCode(int rep)
	{
			CWE ret = null;
			try
			{
			IType t = this.GetField(2, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Match Reason Code (QRI-2).
   ///</summary>
  public CWE[] GetMatchReasonCode() {
     CWE[] ret = null;
    try {
        IType[] t = this.GetField(2);  
        ret = new CWE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CWE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  ///<summary>
  /// Returns the total repetitions of Match Reason Code (QRI-2).
   ///</summary>
  public int MatchReasonCodeRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(2);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns Algorithm Descriptor(QRI-3).
	///</summary>
	public CWE AlgorithmDescriptor
	{
		get{
			CWE ret = null;
			try
			{
			IType t = this.GetField(3, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }


}}