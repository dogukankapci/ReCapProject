using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate < DateTime.Now || rental.ReturnDate == null)
            {
                return new ErrorResult(Messages.CarRentalDateError);
            }

            else if (rental.RentDate >= DateTime.Now && rental.ReturnDate >= DateTime.Now)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.CarRented);
            }

            else
            {
                return new ErrorResult(Messages.Error);
            }
        }

        public IResult Delete(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Rental> Get(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        public IDataResult<List<Rental>> GetAll()
        {
            throw new NotImplementedException();
        }

        #region NOT
        // ReturnDate aracı kiralarken verilmesi gereken bir bilgi. Bu durumda ReturnDate'i null olmayan yani kiralanmış araçlar üzerinde güncelleme yapılabilsin.
        #endregion
        public IResult Update(Rental rental)
        {
            if (rental.ReturnDate != null)
            {
                _rentalDal.Update(rental);
                return new SuccessResult();
            }

            else
            {
                return new ErrorResult();
            }
        }
    }
}
