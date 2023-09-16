public class UnitOfWork
{
    private readonly DbSession _session;


    public UnitOfWork(DbSession session)
    {
        _session = session;

    }


    public void BeginTran()
    {
        _session.Transaction = _session.Connection.BeginTransaction();
    }
    public void Commit()
    {
        _session.Transaction.Commit();

        _session.Dispose();
    }
    public void RollBack()
    {
        _session.Transaction.Rollback();

        _session.Dispose();

    }

}

