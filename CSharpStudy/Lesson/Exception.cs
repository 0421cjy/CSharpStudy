using System;
using System.Data.SqlClient;

namespace CSharpStudy.Lesson
{
    class Exception
    {
        public void foo()
        {
            // try 블록은 실제 실행하고 싶은 프로그램 명령문들을 갖는 블럭이다.
            // catch 
            // finally는 Exception이 발생했던 발생하지 않았던 상관없이 마지막에 반드시 실행되는 블럭이다.

            try
            {

            }
            catch(ArgumentException ex)
            {

            }
            catch (InvalidOperationException ex)
            {

            }
            finally
            {

            }

            // catch문에서 기존의 Exception을 다시 상위 호출자로 보내고 싶을 떄가 있는데, 이때 throw를 사용한다.
            try
            {
                // 실행 문장들
                Step1();
                Step2();
                Step3();
            }
            catch (IndexOutOfRangeException ex)
            {
                // 새로운 Exception 생성하여 throw
                throw; // new MyException("Invalid index", ex);
            }
            catch (ApplicationException ex)
            {
                bool success = true; // Log(ex);
                if (!success)
                {
                    // 기존 Exception을 throw
                    throw ex;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }

            string connStr = "Data source=(local);Integrated security=true;";
            string sql = "SELECT COUNT(1) FROM sys.objects";
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                object count = cmd.ExecuteScalar();
                Console.WriteLine(count);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }


        public void Step1()
        {

        }

        public void Step2()
        {

        }

        public void Step3()
        {

        }
    }
}
