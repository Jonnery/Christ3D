using Christ3D.Application.EventSourcedNormalizers;
using Christ3D.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Christ3D.Application.Services
{
    /// <summary>
    /// 定义 IStudentAppService 服务接口
    /// 并继承IDisposable，显式释放资源
    /// 注意这里我们使用的对象，是视图对象模型
    /// </summary>
    public interface IStudentAppService : IDisposable
    {
        void Register(StudentViewModel StudentViewModel);
        IEnumerable<StudentViewModel> GetAll();
        StudentViewModel GetById(Guid id);
        void Update(StudentViewModel StudentViewModel);
        void Remove(Guid id);
        IList<StudentHistoryData> GetAllHistory(Guid id);
    }
}
