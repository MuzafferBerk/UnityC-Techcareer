using System.Collections.Generic;
using System.Linq;
using OOP_Uygulama1.Models;
using OOP_Uygulama1.Exceptions;

namespace OOP_Uygulama1.Repositories
{
    public class ModelRepository
    {
        private List<Model> _models;

        public ModelRepository()
        {
            _models = new List<Model>();
        }

        public List<Model> GetAll()
        {
            return _models;
        }

        public Model GetById(int id)
        {
            Model? model = _models.Find(x => x.Id == id);
            if (model == null)
            {
                throw new NotFoundException(id);
            }
            return model;
        }

        public void Add(Model model)
        {
            _models.Add(model);
        }

        public void Update(int id, Model updatedModel)
        {
            Model? model = _models.Find(x => x.Id == id);
            if (model == null)
            {
                throw new NotFoundException(id);
            }

            model.Name = updatedModel.Name;
            model.Year = updatedModel.Year;
            model.CreatedTime = updatedModel.CreatedTime;
        }

        public void Delete(int id)
        {
            Model? model = _models.Find(x => x.Id == id);
            if (model == null)
            {
                throw new NotFoundException(id);
            }
            _models.Remove(model);
        }
    }
}
