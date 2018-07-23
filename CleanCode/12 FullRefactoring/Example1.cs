using CleanCode._12_FullRefactoring;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.UI.WebControls;

namespace Project.UserControls
{
    public class PostControl : System.Web.UI.UserControl
    {
        private MainRepository MainRepository;


        protected void Page_Load(object sender, EventArgs e)
        {
            MainRepository = new MainRepository();
            

            if (Page.IsPostBack)
            {
                Post post = new Post()
                {
                    // Map form fields to entity properties
                    Id = Convert.ToInt32(PostId.Value),
                    Title = PostTitle.Text.Trim(),
                    Body = PostBody.Text.Trim()
                };
                ValidationResult results = post.Validate();

                if (results.IsValid)
                {
                    MainRepository.SaveChanges(post);
                }
                else
                {
                    GetErrorMessage(results.Errors);
                }
            }
            else
            {
                // Display form
                Post postFounded = MainRepository.GetPostById(Convert.ToInt32(Request.QueryString["id"]));
                PostBody.Text = postFounded.Body;
                PostTitle.Text = postFounded.Title;

            }
        }

        public void GetErrorMessage(IEnumerable<ValidationError> errors)
        {
            BulletedList summary = (BulletedList)FindControl("ErrorSummary");

            // Display errors to the user
            foreach (var failure in errors)
            {
                Label errorMessage = FindControl(failure.PropertyName + "Error") as Label;

                if (errorMessage == null)
                {
                    summary.Items.Add(new ListItem(failure.ErrorMessage));
                }
                else
                {
                    errorMessage.Text = failure.ErrorMessage;
                }
            }
        }

        public Label PostBody { get; set; }
        public Label PostTitle { get; set; }
        public int? PostId { get; set; }

    }

    #region helpers

    public class DbSet<T> : IQueryable<T>
    {
        public void Add(T entity)
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Expression Expression
        {
            get { throw new NotImplementedException(); }
        }

        public Type ElementType
        {
            get { throw new NotImplementedException(); }
        }

        public IQueryProvider Provider
        {
            get { throw new NotImplementedException(); }
        }
    }

    #endregion

}